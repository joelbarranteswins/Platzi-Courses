﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Major Bug", "S3903:Types should be defined in named namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:Book")]
[assembly: SuppressMessage("Major Bug", "S3903:Types should be defined in named namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:LinqQueries")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Pending>", Scope = "member", Target = "~M:LinqQueries.GetBooksAfter2000~System.Collections.Generic.IEnumerable{Book}")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Pending>", Scope = "member", Target = "~M:LinqQueries.GetBookByPageAndByTitle(System.Int32,System.String)~System.Collections.Generic.IEnumerable{Book}")]
[assembly: SuppressMessage("Design", "CA1050:Declare types in namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:LinqQueries")]
[assembly: SuppressMessage("Design", "CA1050:Declare types in namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:Book")]
[assembly: SuppressMessage("Major Code Smell", "S125:Sections of code should not be commented out", Justification = "<Pending>")]