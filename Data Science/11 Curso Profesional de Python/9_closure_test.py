from closure_exercise import make_division_by
from unittest import TestCase
import unittest

class TestingFunctions(TestCase):
    """Tests to know if the methods works well"""
    
    def test_is_palindrome(self):
        """Testing is_palindrome method"""
        division_by_3 = make_division_by(3)
        division_by_5 = make_division_by(5)
        division_by_18 = make_division_by(18)

        self.assertEqual(division_by_3(18), 6.0)
        self.assertEqual(division_by_5(100), 20.0)
        self.assertEqual(division_by_18(54), 3.0)

if __name__ == '__main__':
    unittest.main()
