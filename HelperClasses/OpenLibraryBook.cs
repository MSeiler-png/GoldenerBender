public class OpenLibraryBook
    {
        [JsonConstructor]
        public OpenLibraryBook(
            [JsonPropertyName("key")] string key,
            [JsonPropertyName("type")] string type,
            [JsonPropertyName("seed")] List<string> seed,
            [JsonPropertyName("title")] string title,
            [JsonPropertyName("title_suggest")] string titleSuggest,
            [JsonPropertyName("edition_count")] int editionCount,
            [JsonPropertyName("edition_key")] List<string> editionKey,
            [JsonPropertyName("publish_date")] List<string> publishDate,
            [JsonPropertyName("publish_year")] List<int> publishYear,
            [JsonPropertyName("first_publish_year")] int firstPublishYear,
            [JsonPropertyName("number_of_pages_median")] int numberOfPagesMedian,
            [JsonPropertyName("lccn")] List<string> lccn,
            [JsonPropertyName("publish_place")] List<string> publishPlace,
            [JsonPropertyName("oclc")] List<string> oclc,
            [JsonPropertyName("contributor")] List<string> contributor,
            [JsonPropertyName("lcc")] List<string> lcc,
            [JsonPropertyName("ddc")] List<string> ddc,
            [JsonPropertyName("isbn")] List<string> isbn,
            [JsonPropertyName("last_modified_i")] int lastModifiedI,
            [JsonPropertyName("ia")] List<string> ia,
            [JsonPropertyName("ebook_count_i")] int ebookCountI,
            [JsonPropertyName("has_fulltext")] bool hasFulltext,
            [JsonPropertyName("public_scan_b")] bool publicScanB,
            [JsonPropertyName("ia_collection_s")] string iaCollectionS,
            [JsonPropertyName("lending_edition_s")] string lendingEditionS,
            [JsonPropertyName("lending_identifier_s")] string lendingIdentifierS,
            [JsonPropertyName("printdisabled_s")] string printdisabledS,
            [JsonPropertyName("cover_edition_key")] string coverEditionKey,
            [JsonPropertyName("cover_i")] int coverI,
            [JsonPropertyName("publisher")] List<string> publisher,
            [JsonPropertyName("language")] List<string> language,
            [JsonPropertyName("author_key")] List<string> authorKey,
            [JsonPropertyName("author_name")] List<string> authorName,
            [JsonPropertyName("author_alternative_name")] List<string> authorAlternativeName,
            [JsonPropertyName("person")] List<string> person,
            [JsonPropertyName("place")] List<string> place,
            [JsonPropertyName("subject")] List<string> subject,
            [JsonPropertyName("time")] List<string> time,
            [JsonPropertyName("id_alibris_id")] List<string> idAlibrisId,
            [JsonPropertyName("id_amazon")] List<string> idAmazon,
            [JsonPropertyName("id_canadian_national_library_archive")] List<string> idCanadianNationalLibraryArchive,
            [JsonPropertyName("id_depósito_legal")] List<string> idDepósitoLegal,
            [JsonPropertyName("id_goodreads")] List<string> idGoodreads,
            [JsonPropertyName("id_google")] List<string> idGoogle,
            [JsonPropertyName("id_librarything")] List<string> idLibrarything,
            [JsonPropertyName("id_overdrive")] List<string> idOverdrive,
            [JsonPropertyName("id_paperback_swap")] List<string> idPaperbackSwap,
            [JsonPropertyName("id_wikidata")] List<string> idWikidata,
            [JsonPropertyName("ia_loaded_id")] List<string> iaLoadedId,
            [JsonPropertyName("ia_box_id")] List<string> iaBoxId,
            [JsonPropertyName("publisher_facet")] List<string> publisherFacet,
            [JsonPropertyName("person_key")] List<string> personKey,
            [JsonPropertyName("place_key")] List<string> placeKey,
            [JsonPropertyName("time_facet")] List<string> timeFacet,
            [JsonPropertyName("person_facet")] List<string> personFacet,
            [JsonPropertyName("subject_facet")] List<string> subjectFacet,
            [JsonPropertyName("_version_")] object version,
            [JsonPropertyName("place_facet")] List<string> placeFacet,
            [JsonPropertyName("lcc_sort")] string lccSort,
            [JsonPropertyName("author_facet")] List<string> authorFacet,
            [JsonPropertyName("subject_key")] List<string> subjectKey,
            [JsonPropertyName("ddc_sort")] string ddcSort,
            [JsonPropertyName("time_key")] List<string> timeKey,
            [JsonPropertyName("first_sentence")] List<string> firstSentence,
            [JsonPropertyName("id_amazon_ca_asin")] List<string> idAmazonCaAsin,
            [JsonPropertyName("id_amazon_co_uk_asin")] List<string> idAmazonCoUkAsin,
            [JsonPropertyName("id_amazon_de_asin")] List<string> idAmazonDeAsin,
            [JsonPropertyName("id_amazon_it_asin")] List<string> idAmazonItAsin,
            [JsonPropertyName("id_bcid")] List<string> idBcid,
            [JsonPropertyName("id_british_national_bibliography")] List<string> idBritishNationalBibliography,
            [JsonPropertyName("id_nla")] List<string> idNla,
            [JsonPropertyName("subtitle")] string subtitle
        )
        {
            this.Key = key;
            this.Type = type;
            this.Seed = seed;
            this.Title = title;
            this.TitleSuggest = titleSuggest;
            this.EditionCount = editionCount;
            this.EditionKey = editionKey;
            this.PublishDate = publishDate;
            this.PublishYear = publishYear;
            this.FirstPublishYear = firstPublishYear;
            this.NumberOfPagesMedian = numberOfPagesMedian;
            this.Lccn = lccn;
            this.PublishPlace = publishPlace;
            this.Oclc = oclc;
            this.Contributor = contributor;
            this.Lcc = lcc;
            this.Ddc = ddc;
            this.Isbn = isbn;
            this.LastModifiedI = lastModifiedI;
            this.Ia = ia;
            this.EbookCountI = ebookCountI;
            this.HasFulltext = hasFulltext;
            this.PublicScanB = publicScanB;
            this.IaCollectionS = iaCollectionS;
            this.LendingEditionS = lendingEditionS;
            this.LendingIdentifierS = lendingIdentifierS;
            this.PrintdisabledS = printdisabledS;
            this.CoverEditionKey = coverEditionKey;
            this.CoverI = coverI;
            this.Publisher = publisher;
            this.Language = language;
            this.AuthorKey = authorKey;
            this.AuthorName = authorName;
            this.AuthorAlternativeName = authorAlternativeName;
            this.Person = person;
            this.Place = place;
            this.Subject = subject;
            this.Time = time;
            this.IdAlibrisId = idAlibrisId;
            this.IdAmazon = idAmazon;
            this.IdCanadianNationalLibraryArchive = idCanadianNationalLibraryArchive;
            this.IdDepósitoLegal = idDepósitoLegal;
            this.IdGoodreads = idGoodreads;
            this.IdGoogle = idGoogle;
            this.IdLibrarything = idLibrarything;
            this.IdOverdrive = idOverdrive;
            this.IdPaperbackSwap = idPaperbackSwap;
            this.IdWikidata = idWikidata;
            this.IaLoadedId = iaLoadedId;
            this.IaBoxId = iaBoxId;
            this.PublisherFacet = publisherFacet;
            this.PersonKey = personKey;
            this.PlaceKey = placeKey;
            this.TimeFacet = timeFacet;
            this.PersonFacet = personFacet;
            this.SubjectFacet = subjectFacet;
            this.Version = version;
            this.PlaceFacet = placeFacet;
            this.LccSort = lccSort;
            this.AuthorFacet = authorFacet;
            this.SubjectKey = subjectKey;
            this.DdcSort = ddcSort;
            this.TimeKey = timeKey;
            this.FirstSentence = firstSentence;
            this.IdAmazonCaAsin = idAmazonCaAsin;
            this.IdAmazonCoUkAsin = idAmazonCoUkAsin;
            this.IdAmazonDeAsin = idAmazonDeAsin;
            this.IdAmazonItAsin = idAmazonItAsin;
            this.IdBcid = idBcid;
            this.IdBritishNationalBibliography = idBritishNationalBibliography;
            this.IdNla = idNla;
            this.Subtitle = subtitle;
        }

        [JsonPropertyName("key")]
        public string Key { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("seed")]
        public IReadOnlyList<string> Seed { get; }

        [JsonPropertyName("title")]
        public string Title { get; }

        [JsonPropertyName("title_suggest")]
        public string TitleSuggest { get; }

        [JsonPropertyName("edition_count")]
        public int EditionCount { get; }

        [JsonPropertyName("edition_key")]
        public IReadOnlyList<string> EditionKey { get; }

        [JsonPropertyName("publish_date")]
        public IReadOnlyList<string> PublishDate { get; }

        [JsonPropertyName("publish_year")]
        public IReadOnlyList<int> PublishYear { get; }

        [JsonPropertyName("first_publish_year")]
        public int FirstPublishYear { get; }

        [JsonPropertyName("number_of_pages_median")]
        public int NumberOfPagesMedian { get; }

        [JsonPropertyName("lccn")]
        public IReadOnlyList<string> Lccn { get; }

        [JsonPropertyName("publish_place")]
        public IReadOnlyList<string> PublishPlace { get; }

        [JsonPropertyName("oclc")]
        public IReadOnlyList<string> Oclc { get; }

        [JsonPropertyName("contributor")]
        public IReadOnlyList<string> Contributor { get; }

        [JsonPropertyName("lcc")]
        public IReadOnlyList<string> Lcc { get; }

        [JsonPropertyName("ddc")]
        public IReadOnlyList<string> Ddc { get; }

        [JsonPropertyName("isbn")]
        public IReadOnlyList<string> Isbn { get; }

        [JsonPropertyName("last_modified_i")]
        public int LastModifiedI { get; }

        [JsonPropertyName("ia")]
        public IReadOnlyList<string> Ia { get; }

        [JsonPropertyName("ebook_count_i")]
        public int EbookCountI { get; }

        [JsonPropertyName("has_fulltext")]
        public bool HasFulltext { get; }

        [JsonPropertyName("public_scan_b")]
        public bool PublicScanB { get; }

        [JsonPropertyName("ia_collection_s")]
        public string IaCollectionS { get; }

        [JsonPropertyName("lending_edition_s")]
        public string LendingEditionS { get; }

        [JsonPropertyName("lending_identifier_s")]
        public string LendingIdentifierS { get; }

        [JsonPropertyName("printdisabled_s")]
        public string PrintdisabledS { get; }

        [JsonPropertyName("cover_edition_key")]
        public string CoverEditionKey { get; }

        [JsonPropertyName("cover_i")]
        public int CoverI { get; }

        [JsonPropertyName("publisher")]
        public IReadOnlyList<string> Publisher { get; }

        [JsonPropertyName("language")]
        public IReadOnlyList<string> Language { get; }

        [JsonPropertyName("author_key")]
        public IReadOnlyList<string> AuthorKey { get; }

        [JsonPropertyName("author_name")]
        public IReadOnlyList<string> AuthorName { get; }

        [JsonPropertyName("author_alternative_name")]
        public IReadOnlyList<string> AuthorAlternativeName { get; }

        [JsonPropertyName("person")]
        public IReadOnlyList<string> Person { get; }

        [JsonPropertyName("place")]
        public IReadOnlyList<string> Place { get; }

        [JsonPropertyName("subject")]
        public IReadOnlyList<string> Subject { get; }

        [JsonPropertyName("time")]
        public IReadOnlyList<string> Time { get; }

        [JsonPropertyName("id_alibris_id")]
        public IReadOnlyList<string> IdAlibrisId { get; }

        [JsonPropertyName("id_amazon")]
        public IReadOnlyList<string> IdAmazon { get; }

        [JsonPropertyName("id_canadian_national_library_archive")]
        public IReadOnlyList<string> IdCanadianNationalLibraryArchive { get; }

        [JsonPropertyName("id_depósito_legal")]
        public IReadOnlyList<string> IdDepósitoLegal { get; }

        [JsonPropertyName("id_goodreads")]
        public IReadOnlyList<string> IdGoodreads { get; }

        [JsonPropertyName("id_google")]
        public IReadOnlyList<string> IdGoogle { get; }

        [JsonPropertyName("id_librarything")]
        public IReadOnlyList<string> IdLibrarything { get; }

        [JsonPropertyName("id_overdrive")]
        public IReadOnlyList<string> IdOverdrive { get; }

        [JsonPropertyName("id_paperback_swap")]
        public IReadOnlyList<string> IdPaperbackSwap { get; }

        [JsonPropertyName("id_wikidata")]
        public IReadOnlyList<string> IdWikidata { get; }

        [JsonPropertyName("ia_loaded_id")]
        public IReadOnlyList<string> IaLoadedId { get; }

        [JsonPropertyName("ia_box_id")]
        public IReadOnlyList<string> IaBoxId { get; }

        [JsonPropertyName("publisher_facet")]
        public IReadOnlyList<string> PublisherFacet { get; }

        [JsonPropertyName("person_key")]
        public IReadOnlyList<string> PersonKey { get; }

        [JsonPropertyName("place_key")]
        public IReadOnlyList<string> PlaceKey { get; }

        [JsonPropertyName("time_facet")]
        public IReadOnlyList<string> TimeFacet { get; }

        [JsonPropertyName("person_facet")]
        public IReadOnlyList<string> PersonFacet { get; }

        [JsonPropertyName("subject_facet")]
        public IReadOnlyList<string> SubjectFacet { get; }

        [JsonPropertyName("_version_")]
        public object Version { get; }

        [JsonPropertyName("place_facet")]
        public IReadOnlyList<string> PlaceFacet { get; }

        [JsonPropertyName("lcc_sort")]
        public string LccSort { get; }

        [JsonPropertyName("author_facet")]
        public IReadOnlyList<string> AuthorFacet { get; }

        [JsonPropertyName("subject_key")]
        public IReadOnlyList<string> SubjectKey { get; }

        [JsonPropertyName("ddc_sort")]
        public string DdcSort { get; }

        [JsonPropertyName("time_key")]
        public IReadOnlyList<string> TimeKey { get; }

        [JsonPropertyName("first_sentence")]
        public IReadOnlyList<string> FirstSentence { get; }

        [JsonPropertyName("id_amazon_ca_asin")]
        public IReadOnlyList<string> IdAmazonCaAsin { get; }

        [JsonPropertyName("id_amazon_co_uk_asin")]
        public IReadOnlyList<string> IdAmazonCoUkAsin { get; }

        [JsonPropertyName("id_amazon_de_asin")]
        public IReadOnlyList<string> IdAmazonDeAsin { get; }

        [JsonPropertyName("id_amazon_it_asin")]
        public IReadOnlyList<string> IdAmazonItAsin { get; }

        [JsonPropertyName("id_bcid")]
        public IReadOnlyList<string> IdBcid { get; }

        [JsonPropertyName("id_british_national_bibliography")]
        public IReadOnlyList<string> IdBritishNationalBibliography { get; }

        [JsonPropertyName("id_nla")]
        public IReadOnlyList<string> IdNla { get; }

        [JsonPropertyName("subtitle")]
        public string Subtitle { get; }
    }
