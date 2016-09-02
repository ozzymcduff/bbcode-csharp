using System;
using BBCode;
using NUnit.Framework;

namespace tests
{
        [TestFixture]
        public class Test_bBCode
        {
            [Test]
            public void SomeRandomTest()
            {
                Assert.AreEqual("<b> asdfdsf <b></b></b>", BBRenderer.Render("[b] asdfdsf [b]"));
                Assert.AreEqual("dsaf adsaf p] asdfdsf <b></b>", BBRenderer.Render("dsaf adsaf p] asdfdsf [b]"));
                Assert.AreEqual(" sdfdskf h;as[] sdfa  sdf [psa] asdfdsf <b>fdsjahjkdsh sdf</b>",
                                BBRenderer.Render(" sdfdskf h;as[] sdfa  sdf [psa] asdfdsf [b]fdsjahjkdsh sdf"));
                Assert.AreEqual(" sdfdskf h;as<b> sdfa<i> </i></b> sdf[/i] [psa] asdfdsf <i><b>fdsjahjkdsh sdf</b></i>",
                                BBRenderer.Render(
                                    " sdfdskf h;as[b] sdfa[i] [/b] sdf[/i] [psa] asdfdsf [i][b]fdsjahjkdsh sdf"));
                Assert.AreEqual(" sdfdskf h;as<b> sdfa<i>  sdf [psa] asdfdsf <i><b>fdsjahjkdsh sdf</b></i></i></b>",
                                BBRenderer.Render(" sdfdskf h;as[b] sdfa[i]  sdf [psa] asdfdsf [i][b]fdsjahjkdsh sdf"));
                Assert.AreEqual(" sdfdskf h;as<span style=\"color:#000000\" > sdfa  sdf [psa] </span>",
                                BBRenderer.Render(" sdfdskf h;as[color=svart] sdfa  sdf [psa] "));
            }

        }
}
