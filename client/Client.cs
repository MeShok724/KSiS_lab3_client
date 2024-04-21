using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Ksis_lab3
{
    public class Client
    {
        private string[] mimo_types = { "text/plain", "image/jpeg" };
        public HttpClient HttpClient = new HttpClient();
        public string _serverAddress = "http://localhost:5252/api/files";
        public string _filePath = "C:\\BSUIR\\TI\\lab3\\new.jpg";
        public string _fileName = "new.jpg";
        public event Action<string> ServerResponse;
        public event Action<string> ServerResponseFile;

        public async void PostFile(string filePath, string newFilePath)
        {
            using (MultipartFormDataContent multiContent = new MultipartFormDataContent())
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                multiContent.Add(new ByteArrayContent(fileBytes), "fileBytes", newFilePath);
                using (var response = await HttpClient.PostAsync(_serverAddress + "/post", multiContent))
                {
                    ServerResponse(response.IsSuccessStatusCode?"Success":"Error "+response.StatusCode);
                }
            }

            // using (var multipartFormContent = new MultipartFormDataContent())
            // {
            //     var fileStreamContent = new StreamContent(File.OpenRead(filePath));
            //     fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue(mimo_types[0]);
            //     multipartFormContent.Add(fileStreamContent, name: "file", fileName: _fileName);
            //     using (var response = await HttpClient.PostAsync(_serverAddress, multipartFormContent))
            //     {
            //         string responseText = await response.Content.ReadAsStringAsync();
            //         Console.WriteLine(responseText);
            //     }
            // }
        }

        public async void GetFile(string filePath)
        {
            HttpResponseMessage response = await HttpClient.GetAsync($"{_serverAddress}/get?filePath={Uri.EscapeDataString(filePath)}");
            if (response.IsSuccessStatusCode)
            {
                // Считываем содержимое ответа (файла) в байтовый массив
                byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                // Преобразуем байтовый массив в строку с использованием UTF-8 кодировки
                string fileContent = Encoding.UTF8.GetString(fileBytes);

                ServerResponseFile(fileContent);
                ServerResponse("Success");
            }
            else
            {
                ServerResponse($"Error {response.StatusCode}");
            }
        }

        public async void PutFile(string filePath, string newFile)
        {
            byte[] fileBytes = File.ReadAllBytes(newFile);
            HttpContent content = new ByteArrayContent(fileBytes);
            string fullUrl = _serverAddress + "/put/" + filePath;
            using (var response = await HttpClient.PutAsync(fullUrl, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    ServerResponse("Success");
                }else
                {
                    ServerResponse($"Error {response.StatusCode}");
                }
            }
        }

        public async void DeleteFile(string filePath)
        {
            string fullUrl = _serverAddress + "/delete/" + filePath;
            using (var response = await HttpClient.DeleteAsync(fullUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    ServerResponse("Success");
                }else
                {
                    ServerResponse($"Error {response.StatusCode}");
                }
            }
        }

        public async void CopyFile(string SourcePath, string DestPath)
        {
            // Формируем URL для вызова метода на сервере
            string apiUrl = $"{_serverAddress}/copy?sourcePath={SourcePath}&destinationPath={DestPath}";

            // Отправляем POST-запрос на сервер
            using (HttpResponseMessage response = await HttpClient.PostAsync(apiUrl, null))
            {
                if (response.IsSuccessStatusCode)
                {
                    ServerResponse("Файл успешно скопирован.");
                }
                else
                {
                    ServerResponse($"Ошибка при копировании файла. Код ошибки: {response.StatusCode}");
                }
            }
            // Проверяем успешность выполнения запроса
            
            // string fullUrl = _serverAddress + "/copy/" + SourcePath + "/" + DestPath;
            // using (var response = await HttpClient.GetAsync(fullUrl))
            // {
            //     if (response.IsSuccessStatusCode)
            //     {
            //         ServerResponse("Success");
            //     }else
            //     {
            //         ServerResponse($"Error {response.StatusCode}");
            //     }
            // }
        }

        public async void MoveFile(string SourcePath, string DestPath)
        {
            // Формируем URL для вызова метода на сервере
            string apiUrl = $"{_serverAddress}/move?sourcePath={SourcePath}&destinationPath={DestPath}";

            // Отправляем POST-запрос на сервер
            using (HttpResponseMessage response = await HttpClient.PostAsync(apiUrl, null))
            {
                if (response.IsSuccessStatusCode)
                {
                    ServerResponse("Файл успешно перемещен.");
                }
                else
                {
                    ServerResponse($"Ошибка при перемещении файла. Код ошибки: {response.StatusCode}");
                }
            }
            // string fullUrl = _serverAddress + "/move/" + SourcePath + "/" + DestPath;
            // using (var response = await HttpClient.GetAsync(fullUrl))
            // {
            //     if (response.IsSuccessStatusCode)
            //     {
            //         ServerResponse("Success");
            //     }else
            //     {
            //         ServerResponse($"Error {response.StatusCode}");
            //     }
            // }
        }
    }
}