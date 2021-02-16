﻿using System;

namespace Nuke.Common.Tools.CorFlags
{
    partial class CorFlagsSettings
    {
        private string GetILOnly()
        {
            return ToPlusMinus(ILOnly);
        }

        private string GetRequire32Bit()
        {
            return ToPlusMinus(Require32Bit);
        }

        private string GetPrefer32Bit()
        {
            return ToPlusMinus(Prefer32Bit);
        }

        private string ToPlusMinus(bool? value)
        {
            return value switch
            {
                true => "+",
                false => "-",
                null => null
            };
        }
    }
}
