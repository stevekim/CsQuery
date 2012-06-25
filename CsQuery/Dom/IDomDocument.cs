﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsQuery.Utility;

namespace CsQuery
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDomDocument : IDomContainer
    {
      
        /// <summary>
        /// The primary selection index
        /// </summary>
        RangeSortedDictionary<IDomObject> SelectorXref { get; }
        void AddToIndex(string key, IDomIndexedNode element);
        void AddToIndex(IDomIndexedNode element);
        void RemoveFromIndex(string key);
        void RemoveFromIndex(IDomIndexedNode element);
        IEnumerable<IDomObject> QueryIndex(string subKey, int depth, bool includeDescendants);
        IEnumerable<IDomObject> QueryIndex(string subKey);

        IDomDocumentType DocTypeNode {get;}
        DocType DocType { get; set; }
        DomRenderingOptions DomRenderingOptions { get; set; }
        IDomElement GetElementById(string id);
        IDomElement CreateElement(string nodeName);
        IDomText CreateTextNode(string text);
        IDomComment CreateComment(string comment);
      
        IDomElement QuerySelector(string tagName);
        IList<IDomElement> QuerySelectorAll(string tagName);
        
        IDomElement GetElementByTagName(string tagName);
        IList<IDomElement> GetElementsByTagName(string tagName);

        /// <summary>
        /// Return the body element for this DOM
        /// </summary>
        IDomElement Body { get; }

        // void SetOwner(CsQuery owner);
        int TokenizeString(int startIndex, int length);
        string GetTokenizedString(int index);
        char[] SourceHtml { get; }
        
        
        /// <summary>
        /// Any user data to be persisted with this DOM
        /// </summary>
        IDictionary<string, object> Data { get; set; }
    }
}
