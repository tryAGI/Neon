
#nullable enable

namespace Neon
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDeployRequestRuntime
    {
        /// <summary>
        /// 
        /// </summary>
        Nodejs24,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDeployRequestRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDeployRequestRuntime value)
        {
            return value switch
            {
                FunctionDeployRequestRuntime.Nodejs24 => "nodejs24",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDeployRequestRuntime? ToEnum(string value)
        {
            return value switch
            {
                "nodejs24" => FunctionDeployRequestRuntime.Nodejs24,
                _ => null,
            };
        }
    }
}