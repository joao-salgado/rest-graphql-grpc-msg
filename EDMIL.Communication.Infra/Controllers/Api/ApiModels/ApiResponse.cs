﻿namespace EDMIL.Communication.Infra.Controllers.Api.ApiModels
{
    public class ApiResponse<TData>
    {
        public TData Data { get; private set; }

        public ApiResponse(TData data)
            => Data = data;
    }
}
