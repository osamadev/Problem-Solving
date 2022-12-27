# 219. Contains Duplicate II
# https://leetcode.com/problems/contains-duplicate-ii/description/

class Solution(object):
    def containsNearbyDuplicate(self, nums, k):
        dict = {}
        for i, item in enumerate(nums):
            if item in dict:
                if i - dict[item] <= k: return True
            dict[item] = i
        return False