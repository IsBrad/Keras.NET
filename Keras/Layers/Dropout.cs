namespace Keras.Layers
{
    /// <summary>
    ///     Applies Dropout to the input.
    ///     Dropout consists in randomly setting a fraction rate of input units to 0 at each update during training time, which
    ///     helps prevent overfitting.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Dropout : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Dropout" /> class.
        /// </summary>
        /// <param name="rate">float between 0 and 1. Fraction of the input units to drop.</param>
        /// <param name="noise_shape">
        ///     1D integer tensor representing the shape of the binary dropout mask that will be multiplied
        ///     with the input. For instance, if your inputs have shape  (batch_size, timesteps, features) and you want the dropout
        ///     mask to be the same for all timesteps, you can use noise_shape=(batch_size, 1, features).
        /// </param>
        /// <param name="seed">The random seed integer.</param>
        public Dropout(double rate, Shape noise_shape = null, int? seed = null)
        {
            Parameters["rate"] = rate;
            Parameters["noise_shape"] = noise_shape;
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.layers.Dropout;
            Init();
        }
    }
}