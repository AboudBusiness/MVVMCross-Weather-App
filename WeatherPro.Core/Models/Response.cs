﻿namespace WeatherPro.Core.Models
{
    public class Response
    {
        public object Result { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}
