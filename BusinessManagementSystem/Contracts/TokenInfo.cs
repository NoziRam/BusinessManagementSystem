﻿namespace BusinessManagementSystem.Contracts
{
    public record TokenInfo
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
