/* 
 * Web of Science API Lite
 *
 * A responsive API that supports rich searching across the Web of Science Core Collection to retrieve core article metadata.  This service provides a great way to reuse Web of Science data both internally and externally to enhance  institutional repositories and research networking systems with best-in-class data. This API supports searching across the Web of Science to retrieve item-level metadata with limited fields:  - UT (Unique Identifier) - Authors - Author keywords - Document type - Title - Issue - Pages - Publication date - Source title - Volume - DOI - ISBN - ISSN   The API supports JSON and XML responses, and this documentation supports trying both response types. 
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The source of this article; journal, book or medium in which the document was published
    /// </summary>
    [DataContract]
        public partial class Source :  IEquatable<Source>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="pages">Pages range in the source.</param>
        /// <param name="sourceTitle">The title of the source in which the document was published.</param>
        /// <param name="issue">Issue Number.</param>
        /// <param name="volume">Volume number.</param>
        /// <param name="specialIssue">Special issue, in case was published to a special issue journal.</param>
        /// <param name="bookSeriesTitle">Book series title - in case the article is published in book series.</param>
        /// <param name="publishedBiblioDate">Published Date.</param>
        /// <param name="publishedBiblioYear">Published Year.</param>
        public Source(List<string> pages = default(List<string>), List<string> sourceTitle = default(List<string>), List<string> issue = default(List<string>), List<string> volume = default(List<string>), List<string> specialIssue = default(List<string>), List<string> bookSeriesTitle = default(List<string>), List<string> publishedBiblioDate = default(List<string>), List<string> publishedBiblioYear = default(List<string>))
        {
            this.Pages = pages;
            this.SourceTitle = sourceTitle;
            this.Issue = issue;
            this.Volume = volume;
            this.SpecialIssue = specialIssue;
            this.BookSeriesTitle = bookSeriesTitle;
            this.PublishedBiblioDate = publishedBiblioDate;
            this.PublishedBiblioYear = publishedBiblioYear;
        }
        
        /// <summary>
        /// Pages range in the source
        /// </summary>
        /// <value>Pages range in the source</value>
        [DataMember(Name="Pages", EmitDefaultValue=false)]
        public List<string> Pages { get; set; }

        /// <summary>
        /// The title of the source in which the document was published
        /// </summary>
        /// <value>The title of the source in which the document was published</value>
        [DataMember(Name="SourceTitle", EmitDefaultValue=false)]
        public List<string> SourceTitle { get; set; }

        /// <summary>
        /// Issue Number
        /// </summary>
        /// <value>Issue Number</value>
        [DataMember(Name="Issue", EmitDefaultValue=false)]
        public List<string> Issue { get; set; }

        /// <summary>
        /// Volume number
        /// </summary>
        /// <value>Volume number</value>
        [DataMember(Name="Volume", EmitDefaultValue=false)]
        public List<string> Volume { get; set; }

        /// <summary>
        /// Special issue, in case was published to a special issue journal
        /// </summary>
        /// <value>Special issue, in case was published to a special issue journal</value>
        [DataMember(Name="SpecialIssue", EmitDefaultValue=false)]
        public List<string> SpecialIssue { get; set; }

        /// <summary>
        /// Book series title - in case the article is published in book series
        /// </summary>
        /// <value>Book series title - in case the article is published in book series</value>
        [DataMember(Name="BookSeriesTitle", EmitDefaultValue=false)]
        public List<string> BookSeriesTitle { get; set; }

        /// <summary>
        /// Published Date
        /// </summary>
        /// <value>Published Date</value>
        [DataMember(Name="Published.BiblioDate", EmitDefaultValue=false)]
        public List<string> PublishedBiblioDate { get; set; }

        /// <summary>
        /// Published Year
        /// </summary>
        /// <value>Published Year</value>
        [DataMember(Name="Published.BiblioYear", EmitDefaultValue=false)]
        public List<string> PublishedBiblioYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Source {\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  SourceTitle: ").Append(SourceTitle).Append("\n");
            sb.Append("  Issue: ").Append(Issue).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  SpecialIssue: ").Append(SpecialIssue).Append("\n");
            sb.Append("  BookSeriesTitle: ").Append(BookSeriesTitle).Append("\n");
            sb.Append("  PublishedBiblioDate: ").Append(PublishedBiblioDate).Append("\n");
            sb.Append("  PublishedBiblioYear: ").Append(PublishedBiblioYear).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Source);
        }

        /// <summary>
        /// Returns true if Source instances are equal
        /// </summary>
        /// <param name="input">Instance of Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Source input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pages == input.Pages ||
                    this.Pages != null &&
                    input.Pages != null &&
                    this.Pages.SequenceEqual(input.Pages)
                ) && 
                (
                    this.SourceTitle == input.SourceTitle ||
                    this.SourceTitle != null &&
                    input.SourceTitle != null &&
                    this.SourceTitle.SequenceEqual(input.SourceTitle)
                ) && 
                (
                    this.Issue == input.Issue ||
                    this.Issue != null &&
                    input.Issue != null &&
                    this.Issue.SequenceEqual(input.Issue)
                ) && 
                (
                    this.Volume == input.Volume ||
                    this.Volume != null &&
                    input.Volume != null &&
                    this.Volume.SequenceEqual(input.Volume)
                ) && 
                (
                    this.SpecialIssue == input.SpecialIssue ||
                    this.SpecialIssue != null &&
                    input.SpecialIssue != null &&
                    this.SpecialIssue.SequenceEqual(input.SpecialIssue)
                ) && 
                (
                    this.BookSeriesTitle == input.BookSeriesTitle ||
                    this.BookSeriesTitle != null &&
                    input.BookSeriesTitle != null &&
                    this.BookSeriesTitle.SequenceEqual(input.BookSeriesTitle)
                ) && 
                (
                    this.PublishedBiblioDate == input.PublishedBiblioDate ||
                    this.PublishedBiblioDate != null &&
                    input.PublishedBiblioDate != null &&
                    this.PublishedBiblioDate.SequenceEqual(input.PublishedBiblioDate)
                ) && 
                (
                    this.PublishedBiblioYear == input.PublishedBiblioYear ||
                    this.PublishedBiblioYear != null &&
                    input.PublishedBiblioYear != null &&
                    this.PublishedBiblioYear.SequenceEqual(input.PublishedBiblioYear)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Pages != null)
                    hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.SourceTitle != null)
                    hashCode = hashCode * 59 + this.SourceTitle.GetHashCode();
                if (this.Issue != null)
                    hashCode = hashCode * 59 + this.Issue.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.SpecialIssue != null)
                    hashCode = hashCode * 59 + this.SpecialIssue.GetHashCode();
                if (this.BookSeriesTitle != null)
                    hashCode = hashCode * 59 + this.BookSeriesTitle.GetHashCode();
                if (this.PublishedBiblioDate != null)
                    hashCode = hashCode * 59 + this.PublishedBiblioDate.GetHashCode();
                if (this.PublishedBiblioYear != null)
                    hashCode = hashCode * 59 + this.PublishedBiblioYear.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
