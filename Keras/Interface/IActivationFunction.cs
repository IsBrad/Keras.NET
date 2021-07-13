using System;
using System.Collections.Generic;
using System.Text;

namespace Keras.Interface
{

    public interface IKerasString
    {
        string StringValue { get; }
    }

    public interface IPaddingMethod : IKerasString
    {
    }

    public interface IActivationFunction : IKerasString
    {
    }
}
