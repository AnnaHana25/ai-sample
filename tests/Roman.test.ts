import { romanToInt } from '../Roman';

describe('romanToInt', () => {
  it('should convert single roman numerals correctly', () => {
    expect(romanToInt('I')).toBe(1);
    expect(romanToInt('V')).toBe(5);
    expect(romanToInt('X')).toBe(10);
    expect(romanToInt('L')).toBe(50);
    expect(romanToInt('C')).toBe(100);
    expect(romanToInt('D')).toBe(500);
    expect(romanToInt('M')).toBe(1000);
  });

  it('should convert simple roman numerals correctly', () => {
    expect(romanToInt('III')).toBe(3);
    expect(romanToInt('XV')).toBe(15);
    expect(romanToInt('CL')).toBe(150);
    expect(romanToInt('DCCC')).toBe(800);
  });

  it('should handle subtractive notation correctly', () => {
    expect(romanToInt('IV')).toBe(4);
    expect(romanToInt('IX')).toBe(9);
    expect(romanToInt('XL')).toBe(40);
    expect(romanToInt('XC')).toBe(90);
    expect(romanToInt('CD')).toBe(400);
    expect(romanToInt('CM')).toBe(900);
  });

  it('should convert complex roman numerals correctly', () => {
    expect(romanToInt('MCMLIV')).toBe(1954);
    expect(romanToInt('MCMXCIX')).toBe(1999);
    expect(romanToInt('MMXXI')).toBe(2021);
  });

  it('should handle empty string', () => {
    expect(romanToInt('')).toBe(0);
  });

  it('should throw an error for invalid roman numerals', () => {
    expect(() => romanToInt('INVALID')).toThrow();
    expect(() => romanToInt('ABC')).toThrow();
  });
});
