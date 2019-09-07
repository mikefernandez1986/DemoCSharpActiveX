using System;
using System.Runtime.InteropServices;



namespace DemoCSharpActiveX

{

    /// <summary>

    /// Demo HelloWorld class

    /// </summary>

    [ProgId("DemoCSharpActiveX.HelloWorld")]

    [ClassInterface(ClassInterfaceType.AutoDual)]

    [Guid("EB226149-BEBE-473B-AF07-8007A7A57C0A")]

    [ComVisible(true)]

    public class HelloWord

    {

        [ComVisible(true)]

        public String SayHello()

        {

            return "Hello World!";

        }

    }

}