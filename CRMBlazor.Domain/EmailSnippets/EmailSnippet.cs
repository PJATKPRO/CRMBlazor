using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.EmailSnippets.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.EmailSnippets
{
    public sealed class EmailSnippet : AggregateRoot<EmailSnippetId>
    {


        public static EmailSnippet Create(EmailSnippetId id, string title, string? header, string content, string? footer)
        {
            return new EmailSnippet(id, title, header, content, footer);
        }

        private EmailSnippet(EmailSnippetId id, string title, string? header, string content, string? footer) : base(id)
        {
            Title = title;
            Header = header;
            Content = content;
            Footer = footer;
        }

        public string Title { get; set; }
        public string? Header { get; set; }
        public string Content { get; set; }
        public string? Footer { get; set; }

        private EmailSnippet() { }

    }
}
