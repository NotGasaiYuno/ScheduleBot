﻿using System;

namespace PrimatScheduleBot
{
    public sealed class Insert : ICommand, IHandler
    {
        private readonly BehaviourTree _tree;
        private readonly string _chatId;

        public Insert(string chatId) => _chatId = chatId;

        public string Execute(string message)
        {
            throw new NotImplementedException();
        }

        public void HandleReplyButton(string message)
        {
            throw new NotImplementedException();
        }
    }
}