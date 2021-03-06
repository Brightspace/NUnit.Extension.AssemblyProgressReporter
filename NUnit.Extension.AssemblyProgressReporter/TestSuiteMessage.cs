﻿using System;
using System.Xml;

namespace NUnit.Extension.AssemblyProgressReporter {

	internal enum TestSuiteType {
		Assembly,
		Namespace,
		TestFixture,
		ParameterizedTest
	}

	internal sealed class TestSuiteMessage : XmlMessage {

		public TestSuiteType? Type { get; }

		public override MessageKind Kind => MessageKind.TestSuite;

		public TestSuiteMessage( XmlReader reader ) : base( reader ) {
			TestSuiteType tst;
			if( Enum.TryParse( reader.GetAttribute( "type" ), out tst ) ) {
				Type = tst;
			}
		}

	}

}
