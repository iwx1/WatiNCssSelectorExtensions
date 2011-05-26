﻿using System;
using System.Linq;
using NUnit.Framework;
using WatiN.Core;

namespace WatiN.CssSelectorExtensions.Tests
{
	/// <summary>
	/// Basic CssSelector tests intended to exercise demo each of the selectors as defined and organized in the CSS 3 spec.
	/// </summary>
	[TestFixture]
	public class BasicCssSelectorTests
	{ 
		[Test]
		public void Test001_UniversalSelectors()
		{
			using (Browser browser = new IE("http://localhost:8181/"))
			{
				var links = browser.CssSelectAll("*");

				Console.WriteLine("{0} -- {1}", links.Count(), browser.Elements.Count()); //shouldn't these match?
				Assert.That(links.Count() > 20);
			}
		}

		[Test]
		public void Test002_TypeSelectors()
		{
			using (Browser browser = new IE("http://localhost:8181/"))
			{
				var links = browser.CssSelectAll("a");
				
				Assert.That(links.Count() > 1);
				Assert.That(links.First().Text == "Log In");                
			}
		}

		[Test]
		public void Test003_AttributeSelectors_HasAttribute() 
		{
			using (Browser browser = new IE("http://localhost:8181/"))
			{
				var links = browser.CssSelectAll("a[title]");
				Assert.That(links.Any(e => e.TagName == "A"));
			}
		}

		[Test]
		public void Test004_AttributeSelectors_ExactValue()
		{
			using (Browser browser = new IE("http://localhost:8181/"))
			{
				var links = browser.CssSelectAll("a[title='ASP.NET Website']");
				Assert.That(links.Count() == 1);
			}
			
		}


		[Test, Ignore("Under Construction")]
		public void AttributeSelectors_ContainsExactValue()
		{

		}

		[Test, Ignore("Under Construction")]
		public void AttributeSelectors_ValueBeginsWith()
		{

		}

		[Test, Ignore("Under Construction")]
		public void AttributeSelectors_ValueEndsWith()
		{

		}

		[Test, Ignore("Under Construction")]
		public void AttributeSelectors_ValueContains()
		{

		}

		[Test, Ignore("Under Construction")]
		public void AttributeSelectors_HyphenSeparatedValue()
		{

		}

		[Test, Ignore("Under Construction")]
		public void PseudoSelectors()
		{

		}

		[Test]
		public void Test999_ClassSelectors()
		{
			using (Browser browser = new IE("http://localhost:8181/"))
			{
				var menu = browser.CssSelectAll("table.menu");
				Assert.That(menu.Count() == 1);
			}
		}

		[Test, Ignore("Under Construction")]
		public void IdSelectors()
		{ }

		[Test, Ignore("Under Construction")]
		public void NegationPseudoClass()
		{ }

		[Test, Ignore("Under Construction")]
		public void DescendantCombinator()
		{ }

		[Test, Ignore("Under Construction")]
		public void ChildCombinator()
		{ }

		[Test, Ignore("Under Construction")]
		public void DirectAdjacentCombinator()
		{ }

		[Test, Ignore("Under Construction")]
		public void IndirectAdjacentCombinator()
		{ }

	}
}