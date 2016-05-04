// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

using WixToolset.Simplified.Test.Utility;
using Xunit;

namespace WixToolset.Simplified.Test
{
    public class GeneralTests
    {
        [Fact]
        public void TestHelp()
        {
            SwcTool swc = new SwcTool().Help();
            Assert.Empty(swc.Errors);
        }
    }
}
