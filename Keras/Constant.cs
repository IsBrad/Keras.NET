namespace Keras
{
    /// <summary>
    ///     Initializer that generates tensors initialized to a constant value.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Constant : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Constant" /> class.
        /// </summary>
        /// <param name="value">float; the value of the generator tensors.</param>
        public Constant(float value = 0)
        {
            Parameters["value"] = value;
            PyInstance = Instance.keras.initializers.Constant;
            Init();
        }
    }
}