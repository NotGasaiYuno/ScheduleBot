﻿using System;

namespace PrimatScheduleBot
{
    public sealed class Delete : ICommand, IHandler
    {
        private readonly string _chatId;
        private readonly string _message;
        private readonly BehaviourTree _tree;

        public Delete(string chatId, string message, BehaviourTree tree)
        {
            _chatId = chatId;
            _message = message;
            _tree = tree;
        }

        public string Execute()
        {
            throw new NotImplementedException();
        }

        public void HandleReplyButton(string message)
        {
            throw new NotImplementedException();
        }
    }
}
