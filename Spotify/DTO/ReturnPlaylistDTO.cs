﻿namespace Spotify.DTO
{
    public class ReturnPlaylistDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
