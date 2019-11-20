public class Solution {
	public int SearchInsert(int[] nums, int target) {
		int length = nums.Length;
		int pos = 0;
		if (length == 0) {
			return 0;
		}

		for (; pos < length; pos++) {
			if (nums [pos] >= target) {
				return pos;
			}
		}
		return pos;
	}
}