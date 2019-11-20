public class Solution {
	public int[] SearchRange(int[] nums, int target) {
		int length = nums.Length;
		if (length == 0) {
			return new int[]{ -1, -1 };
		}
		int start = -1, len = -1;
		bool is_get = false;
		for (int i = 0; i < length; i++) {
			if (nums [i] > target) {
				break;
			}
			if (nums [i] == target) {
				if (!is_get) {
					start = i;
					is_get = true;
				}
				len += 1;
			}
		}
		if (is_get) {
			return new int[]{ start, start + len };
		} else {
			return new int[]{ -1, -1 };
		}
	}
}