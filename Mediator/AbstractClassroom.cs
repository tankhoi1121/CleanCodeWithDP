﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Mediator
{
    public abstract class AbstractClassroom
    {
        public abstract void Register(Participant participant);

        public abstract void Send(string from, string to, string message);
    }
}
