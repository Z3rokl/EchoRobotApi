﻿using EchoRoborApi.Models;
using EchoRoborApi.Models.Request.User;
using EchoRobotApi.Models;
using EchoRobotApi.Models.Request.User;
using Microsoft.AspNetCore.Mvc;

namespace EchoRoborApi.Services.Interfaces
{
    public interface IUserService
    {

        public ResponseModel AddUser(UserRequest model);
        public ResponseModel EditUser(EditRequest edit);
        public ResponseModel DeleteUser(int id);
        public Task<ResponseModel> UploadPhotoUser(UserPhotoRequest request);

        public Task<UserResponse> Logging(LoggingRequest request); 
        public Task<Usuario?> GetUser(int id);

    }
}
