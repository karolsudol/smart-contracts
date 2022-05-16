package hello

import "testing"

func TestFibInt(t *testing.T) {
	result := FibInt(30)
	if result != 832040 {
		t.Error("result should be 832040, got", result)
	}
}
