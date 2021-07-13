namespace Keras.Layers.Activation
{
    public class Swish : Activation
    {
        private const string KerasNameToken = "swish";

        public Swish(Shape input_shape = null) : base(KerasNameToken, input_shape)
        {
        }
    }
}