namespace SharedObjects.Enums
{
    /// <summary>
    ///    Post Enum Results
    /// </summary>
    /// <remarks>
    ///     Date:   30/06/2018
    ///     Author: Stephen McCutcheon
    /// </remarks>
    public enum PostEnumResult
    {
        /// <summary>
        ///     Generla Exception error
        /// </summary>
        /// <remarks>
        ///     Date:   30/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        Error = 0,

        /// <summary>
        ///     Message accepted correctly
        /// </summary>
        /// <remarks>
        ///     Date:   30/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        Success = 1,

        /// <summary>
        ///     a Validation error has occured, check the data values
        /// </summary>
        /// <remarks>
        ///     Date:   30/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        ValudationError = 2
    }
}
