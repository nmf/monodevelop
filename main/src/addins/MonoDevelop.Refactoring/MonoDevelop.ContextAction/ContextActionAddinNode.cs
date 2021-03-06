// 
// ContextActionCodon.cs
//  
// Author:
//       Mike Krüger <mkrueger@novell.com>
// 
// Copyright (c) 2011 Novell, Inc (http://www.novell.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using Mono.Addins;

namespace MonoDevelop.ContextAction
{
	public class ContextActionAddinNode : TypeExtensionNode
	{
		[NodeAttribute ("mimeType", Required=true, Description="The mime type of this action.")]
		string mimeType = null;
		
		public string MimeType {
			get {
				return mimeType;
			}
		}
		
		[NodeAttribute ("_title", Required=true, Localizable=true, Description="The title of this action.")]
		string title = null;
		
		public string Title {
			get {
				return title;
			}
		}
		
		[NodeAttribute ("_description", Required=true, Localizable=true,  Description="The description of this action.")]
		string description = null;
		
		public string Description {
			get {
				return description;
			}
		}
		
		ContextAction action;
		public ContextAction Action {
			get {
				if (action == null) {
					action = (ContextAction)CreateInstance ();
					action.Node = this;
				}
				
				return action;
			}
		}
	}
}

