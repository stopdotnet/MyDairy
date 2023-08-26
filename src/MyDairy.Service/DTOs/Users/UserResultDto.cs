﻿using MyDairy.Service.DTOs.Attachment;
using System.ComponentModel.DataAnnotations;

namespace MyDairy.Service.DTOs.Users;

public class UserResultDto
{
    public long Id { get; set; }

    [MaxLength(25)]
    public string Firstname { get; set; }

    [MaxLength(25)]
    public string Lastname { get; set; }

    [MaxLength(25)]
    public string Username { get; set; }

    public AttachmentResultDto Image { get; set; }

    public string Password { get; set; }
}