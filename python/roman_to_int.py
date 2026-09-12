class Solution:
    def romanToInt(self, s: str) -> int:
        dict = {
            'I': 1,
            'V': 5,
            'X': 10,
            'L': 50,
            'C': 100,
            'D': 500,
            'M': 1000
        }

        n = s.replace("IV", ",4,").replace("IX", ",9,").replace("XL", ",40,").replace("XC", ",90,").replace("CD", ",400,").replace("CM", ",900,")
        for k, v in dict.items():
            n = n.replace(k, f",{v},")

        n_list = n.split(",")
        sanitized_list = [x for x in n_list if x != ""]
        print(sanitized_list)
        for k, v in dict.items():
            if k in sanitized_list:
                sanitized_list.append(str(v))
                sanitized_list.remove(k)


        summed_list = [int(n) for n in sanitized_list]
        total = sum(summed_list)
        return total

s = Solution()
print(s.romanToInt("III"))
print(s.romanToInt("IV"))
print(s.romanToInt("IX"))
print(s.romanToInt("LVIII"))
print(s.romanToInt("MCMXCIV"))