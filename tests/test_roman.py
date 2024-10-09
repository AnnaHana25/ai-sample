import unittest
from Roman import Solution

class TestRomanToInt(unittest.TestCase):
    def setUp(self):
        self.solution = Solution()

    def test_single_numeral(self):
        self.assertEqual(self.solution.romanToInt("I"), 1)
        self.assertEqual(self.solution.romanToInt("V"), 5)
        self.assertEqual(self.solution.romanToInt("X"), 10)
        self.assertEqual(self.solution.romanToInt("L"), 50)
        self.assertEqual(self.solution.romanToInt("C"), 100)
        self.assertEqual(self.solution.romanToInt("D"), 500)
        self.assertEqual(self.solution.romanToInt("M"), 1000)

    def test_additive_numerals(self):
        self.assertEqual(self.solution.romanToInt("VII"), 7)
        self.assertEqual(self.solution.romanToInt("CLXVI"), 166)
        self.assertEqual(self.solution.romanToInt("MDCLXVI"), 1666)

    def test_subtractive_numerals(self):
        self.assertEqual(self.solution.romanToInt("IV"), 4)
        self.assertEqual(self.solution.romanToInt("IX"), 9)
        self.assertEqual(self.solution.romanToInt("XL"), 40)
        self.assertEqual(self.solution.romanToInt("XC"), 90)
        self.assertEqual(self.solution.romanToInt("CD"), 400)
        self.assertEqual(self.solution.romanToInt("CM"), 900)

    def test_complex_numerals(self):
        self.assertEqual(self.solution.romanToInt("MCMLIV"), 1954)
        self.assertEqual(self.solution.romanToInt("MCMXCIX"), 1999)
        self.assertEqual(self.solution.romanToInt("MMXXI"), 2021)

    def test_edge_cases(self):
        self.assertEqual(self.solution.romanToInt(""), 0)
        self.assertEqual(self.solution.romanToInt("MMMCMXCIX"), 3999)

if __name__ == '__main__':
    unittest.main()
