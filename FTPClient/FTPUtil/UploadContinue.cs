﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTPUtil
{
    public class UploadContinue : TransferCommand
    {
        public override Command Abort()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override string GetReply()
        {
            throw new NotImplementedException();
        }
    }
}
