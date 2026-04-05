#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Neon.JsonConverters
{
    /// <inheritdoc />
    public class ProjectRecoverResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Neon.ProjectRecoverResponse>
    {
        /// <inheritdoc />
        public override global::Neon.ProjectRecoverResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("project")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("branches")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Neon.ProjectResponse? projectResponse = default;
            global::Neon.BranchesResponse? branches = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        projectResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.ProjectResponse>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        branches = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.BranchesResponse>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (projectResponse == null && branches == null)
            {
                try
                {
                    projectResponse = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.ProjectResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    branches = global::System.Text.Json.JsonSerializer.Deserialize<global::Neon.BranchesResponse>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Neon.ProjectRecoverResponse(
                projectResponse,

                branches
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Neon.ProjectRecoverResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsProjectResponse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ProjectResponse, typeof(global::Neon.ProjectResponse), options);
            }
            else if (value.IsBranches)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Branches, typeof(global::Neon.BranchesResponse), options);
            }
        }
    }
}