﻿using Application.DTOs.Notification;
using Application.DTOs.User;
using MediatR;

namespace Application.Features.Notification.Queries.GetNotifications;

public class GetNotificationsCommand : IRequest<List<NotificationDto>>
{
    public UserRequestDto UserRequestDto { get; set; }
}