using Keras.Helper;
using Numpy;

namespace Keras.Datasets
{
    /// <summary>
    ///     Dataset of 50,000 32x32 color training images, labeled over 10 categories, and 10,000 test images.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Cifar10 : Base
    {
        /// <summary>
        ///     Loads the data.
        /// </summary>
        /// <returns></returns>
        public static ((NDarray, NDarray), (NDarray, NDarray)) LoadData()
        {
            var dlist = TupleSolver.TupleToList(Instance.keras.datasets.cifar10.load_data());
            return ((dlist[0], dlist[1]), (dlist[2], dlist[3]));
        }
    }
}