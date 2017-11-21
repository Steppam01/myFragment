using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyFragment.Droid
{
    class FinancialNews
    {
        public static string[] Headlines =
        {
            "GOOG",
            "AMZN",
            "MSFT",
            "FB",
            "AAPL",
            "NFLX"
        };

        public static string[] Stories =
        {
            "Larry Page announces new record profit in this quarter." +
            "\nThe company's management is looking into acquiring a couple of promising startups." +
            "\nThe stock price rallied in the after hours trading",
            "In today's press conference, Jeff Bezos, the CEO of Amazon, announced that the company is interested in acquiring Walgreens " +
            "in order to enter domestic drug prescription marketplace." +
            "\nShares of CVS, RitePhapmacy slumped 18% and 25% on the news.",
            "Satya Nadela, CEO Of Microsoft announced new initiative Microsoft is pursuing in the cloud computing in today's press " +
            "conference." +
            "\nHe also forecast bullish outlook for the next quarter. Investors repsonded in the after hours trading by snapping shares of " +
            "Microsoft",
            "Facebook announced that it is innesting heavily in AI resarch today.",
            "Apple Computer announced release of their latest iPhone model, iPhone X." +
            "\nApple stores are well stocked to meet the consumer demand.\nIn many cities throughout the nation, stores will be open until " +
            "midnight to accomodate customers.",
            "Netflix announced another season of their popular series Narcos. It will be filmed on location in Mexico"
        };

    }
}