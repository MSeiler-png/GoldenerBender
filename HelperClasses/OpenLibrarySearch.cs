public class OpenLibrarySearchResult
    {
        [JsonConstructor]
        public OpenLibrarySearchResult(
            [JsonPropertyName("numFound")] int numFound,
            [JsonPropertyName("start")] int start,
            [JsonPropertyName("numFoundExact")] bool numFoundExact,
            [JsonPropertyName("docs")] List<Doc> docs,
            [JsonPropertyName("num_found")] int numFound,
            [JsonPropertyName("q")] string q,
            [JsonPropertyName("offset")] object offset
        )
        {
            this.NumFound = numFound;
            this.Start = start;
            this.NumFoundExact = numFoundExact;
            this.Docs = docs;
            this.NumFound = numFound;
            this.Q = q;
            this.Offset = offset;
        }

        [JsonPropertyName("numFound")]
        public int NumFound { get; }

        [JsonPropertyName("start")]
        public int Start { get; }

        [JsonPropertyName("numFoundExact")]
        public bool NumFoundExact { get; }

        [JsonPropertyName("docs")]
        public IReadOnlyList<Doc> Docs { get; }

        [JsonPropertyName("num_found")]
        public int NumFound { get; }

        [JsonPropertyName("q")]
        public string Q { get; }

        [JsonPropertyName("offset")]
        public object Offset { get; }
    }
