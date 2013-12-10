﻿using System.Collections.Generic;
using System.Linq;

namespace LinguisticsBot
{
	class StringPair
	{
		public string XSAMPA;
		public string IPA;

		public StringPair(string xsampa, string ipa)
		{
			XSAMPA = xsampa;
			IPA = ipa;
		}
	}

	public class XSAMPA
	{
		static List<StringPair> Pairs;

		static XSAMPA()
		{
			Pairs = new List<StringPair>
			{
				new StringPair("a", "a"),
				new StringPair("b", "b"),
				new StringPair("b_<", "ɓ"),
				new StringPair("c", "c"),
				new StringPair("d", "d"),
				new StringPair("d`", "ɖ"),
				new StringPair("d_<", "ɗ"),
				new StringPair("e", "e"),
				new StringPair("f", "f"),
				new StringPair("g", "ɡ"),
				new StringPair("g_<", "ɠ"),
				new StringPair("h", "h"),
				new StringPair("h\\", "ɦ"),
				new StringPair("i", "i"),
				new StringPair("j", "j"),
				new StringPair("j\\", "ʝ"),
				new StringPair("k", "k"),
				new StringPair("l", "l"),
				new StringPair("l`", "ɭ"),
				new StringPair("l\\", "ɺ"),
				new StringPair("m", "m"),
				new StringPair("n", "n"),
				new StringPair("n`", "ɳ"),
				new StringPair("o", "o"),
				new StringPair("p", "p"),
				new StringPair("p\\", "ɸ"),
				new StringPair("q", "q"),
				new StringPair("r", "r"),
				new StringPair("r`", "ɽ"),
				new StringPair("r\\", "ɹ"),
				new StringPair("r\\`", "ɻ"),
				new StringPair("s", "s"),
				new StringPair("s`", "ʂ"),
				new StringPair("s\\", "ɕ"),
				new StringPair("t", "t"),
				new StringPair("t`", "ʈ"),
				new StringPair("u", "u"),
				new StringPair("v", "v"),
				new StringPair("v\\", "ʋ"),
				new StringPair("w", "w"),
				new StringPair("x", "x"),
				new StringPair("x\\", "ɧ"),
				new StringPair("y", "y"),
				new StringPair("z", "z"),
				new StringPair("z`", "ʐ"),
				new StringPair("z\\", "ʑ"),
				new StringPair("A", "ɑ"),
				new StringPair("B", "β"),
				new StringPair("B\\", "ʙ"),
				new StringPair("C", "ç"),
				new StringPair("D", "ð"),
				new StringPair("E", "ɛ"),
				new StringPair("F", "ɱ"),
				new StringPair("G", "ɣ"),
				new StringPair("G\\", "ɢ"),
				new StringPair("G\\_<", "ʛ"),
				new StringPair("H", "ɥ"),
				new StringPair("H\\", "ʜ"),
				new StringPair("I", "ɪ"),
				new StringPair("I\\", "ɪ̵"),
				new StringPair("J", "ɲ"),
				new StringPair("J\\", "ɟ"),
				new StringPair("J\\_<", "ʄ"),
				new StringPair("K", "ɬ"),
				new StringPair("K\\", "ɮ"),
				new StringPair("L", "ʎ"),
				new StringPair("L\\", "ʟ"),
				new StringPair("M", "ɯ"),
				new StringPair("M\\", "ɰ"),
				new StringPair("N", "ŋ"),
				new StringPair("N\\", "ɴ"),
				new StringPair("O", "ɔ"),
				new StringPair("O\\", "ʘ"),
				new StringPair("P", "ʋ"),
				new StringPair("Q", "ɒ"),
				new StringPair("R", "ʁ"),
				new StringPair("R\\", "ʀ"),
				new StringPair("S", "ʃ"),
				new StringPair("T", "θ"),
				new StringPair("U", "ʊ"),
				new StringPair("U\\", "ʊ̵"),
				new StringPair("V", "ʌ"),
				new StringPair("W", "ʍ"),
				new StringPair("X", "χ"),
				new StringPair("X\\", "ħ"),
				new StringPair("Y", "ʏ"),
				new StringPair("Z", "ʒ"),
				new StringPair(".", "."),
				new StringPair("\"", "ˈ"),
				new StringPair("%", "ˌ"),
				new StringPair("'", "ʲ"),
				new StringPair(":", "ː"),
				new StringPair(":\\", "ˑ"),
				new StringPair("@", "ə"),
				new StringPair("@\\", "ɘ"),
				new StringPair("{", "æ"),
				new StringPair("}", "ʉ"),
				new StringPair("1", "ɨ"),
				new StringPair("2", "ø"),
				new StringPair("3", "ɜ"),
				new StringPair("3\\", "ɞ"),
				new StringPair("4", "ɾ"),
				new StringPair("5", "ɫ"),
				new StringPair("6", "ɐ"),
				new StringPair("7", "ɤ"),
				new StringPair("8", "ɵ"),
				new StringPair("9", "œ"),
				new StringPair("&", "ɶ"),
				new StringPair("?", "ʔ"),
				new StringPair("?\\", "ʕ"),
				new StringPair("<\\", "ʢ"),
				new StringPair(">\\", "ʡ"),
				new StringPair("^", "↑"),
				new StringPair("!", "↓"),
				new StringPair("!\\", "ǃ"),
				new StringPair("|", "|"),
				new StringPair("|\\", "ǀ"),
				new StringPair("||", "‖"),
				new StringPair("|\\|\\", "ǁ"),
				new StringPair("=\\", "ǂ"),
				new StringPair("-\\", "‿"),
				new StringPair("_\"", "̈"),
				new StringPair("_+", "̟"),
				new StringPair("_-", "̠"),
				new StringPair("_/", "ˇ"),
				new StringPair("_0", "̥"),
				new StringPair("=", "̩"),
				new StringPair("_>", "ʼ"),
				new StringPair("_?\\", "ˤ"),
				new StringPair("_\\", "ˆ"),
				new StringPair("_^", "̯"),
				new StringPair("_}", "̚"),
				new StringPair("`", "˞"),
				new StringPair("~", "̃"),
				new StringPair("_A", "̘"),
				new StringPair("_a", "̺"),
				new StringPair("_B", "̏"),
				new StringPair("_c", "̜"),
				new StringPair("_d", "̪"),
				new StringPair("_e", "̴"),
				new StringPair("_F", "̂"),
				new StringPair("_G", "ˠ"),
				new StringPair("_H", "́"),
				new StringPair("_h", "ʰ"),
				new StringPair("_j", "ʲ"),
				new StringPair("_k", "̰"),
				new StringPair("_L", "̀"),
				new StringPair("_l", "ˡ"),
				new StringPair("_M", "̄"),
				new StringPair("_m", "̻"),
				new StringPair("_N", "̼"),
				new StringPair("_n", "ⁿ"),
				new StringPair("_O", "̹"),
				new StringPair("_o", "̞"),
				new StringPair("_q", "̙"),
				new StringPair("_R", "̌"),
				new StringPair("_r", "̝"),
				new StringPair("_T", "̋"),
				new StringPair("_t", "̤"),
				new StringPair("_v", "̬"),
				new StringPair("_w", "ʷ"),
				new StringPair("_X", "̆"),
				new StringPair("_x", "̽"),
				new StringPair("tS", "t͡ʃ"),
				new StringPair("dZ", "d͡ʒ"),
				new StringPair("ts", "t͡s"),
				new StringPair("dz", "d͡z"),
			};
			Pairs = Pairs.OrderBy((StringPair x) => x.XSAMPA.Length).Reverse().ToList();
		}

		public static string Translate(string input)
		{
			string output = input;
			foreach (var pair in Pairs)
				output = output.Replace(pair.XSAMPA, pair.IPA);
			return output;
		}

		public static string TranslateText(string input)
		{
			string output = TranslateMarkedSegments(input, '[', ']');
			output = TranslateMarkedSegments(output, '/', '/');
			return output;
		}

		private static string TranslateMarkedSegments(string input, char leftDelimiter, char rightDelimiter)
		{
			string output = "";
			int offset = 0;
			while (true)
			{
				int left = input.IndexOf(leftDelimiter, offset);
				if (left == -1)
				{
					output += input.Substring(offset);
					break;
				}
				int right = input.IndexOf(rightDelimiter, left + 1);
				if (right == -1)
				{
					output += input.Substring(offset);
					break;
				}
				right++;
				string phoneticString = input.Substring(left, right - left);
				output += input.Substring(offset, left - offset);
				output += Translate(phoneticString);
				offset = right;
			}
			return output;
		}
	}
}
