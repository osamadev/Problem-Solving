# 835. Image Overlap
# https://leetcode.com/problems/image-overlap/description/

import numpy as np
class Solution(object):
    def largestOverlap(self, img1, img2):
        """
        :type img1: List[List[int]]
        :type img2: List[List[int]]
        :rtype: int
        """
        a = np.array(img1)
        b = np.array(img2)
        n = a.shape[0]
        a_pad = np.pad(a, n-1, mode='constant')
        new_dim = 2 * n - 1
        conv_matrix = np.zeros(shape=(new_dim, new_dim))
        for r in range(new_dim):
            for c in range(new_dim):
                conv_matrix[r, c] = np.sum(b * a_pad[r:r+n,c:c+n])
        return int(np.max(conv_matrix))