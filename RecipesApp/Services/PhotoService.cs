﻿using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using RecipesApp.Configurations;
using RecipesApp.Services.Contracts;

namespace RecipesApp.Services
{
    public class PhotoService(IOptions<CloudinarySettings> config) : IPhotoService
    {
        private Cloudinary Cloudinary { get; } = new Cloudinary(new Account(
            config.Value.CloudName,
            config.Value.ApiKey,
            config.Value.ApiSecret
        ));

        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation()
                        .Height(500)
                        .Width(750)
                        .Crop("fill")
                        .Gravity(Gravity.Auto),
                    Folder = "ra-net8"
                };

                uploadResult = await Cloudinary.UploadAsync(uploadParams);
            }

            return uploadResult;
        }

        public async Task<DeletionResult> DeletePhotoAsync(string publicId)
        {
            return await Cloudinary.DestroyAsync(new DeletionParams(publicId));
        }
    }
}
