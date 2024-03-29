﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIOverview.Services;

namespace WebAPIOverview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private IVideoStream _videoStream;

        public VideoController(IVideoStream videoStream)
        {
            _videoStream = videoStream;
        }


        [HttpGet("{name}")]
        public async Task<FileStreamResult> Get(string name)
        {
            var stream = await _videoStream.GetVideoByName(name);
            return new FileStreamResult(stream, "video/mp4");
        }
    }
}
