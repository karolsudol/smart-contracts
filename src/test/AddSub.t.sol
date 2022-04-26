// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.12;

import "ds-test/test.sol";
import "../AddSub.sol";
import "solmate/test/utils/DSTestPlus.sol";

contract AddSubTest is DSTestPlus {

    AddSub private xy;

    function setUp() public {
        xy = new AddSub();
    }
    

    function test_Add(uint) public {
        assertEq(xy.add(1,2), 3);
        assertEq(xy.add(1,1), 2);
    }

    function testFail_Add(uint) public {
        assertEq(xy.add(1,2), 4);
        assertEq(xy.add(1,1), 1);
    }

    function test_Sub(uint) public {
        assertEq(xy.sub(2,1), 1);
        assertEq(xy.sub(1,1), 0);
    }

    function testFail_Sub(uint) public {
        assertEq(xy.sub(2,1), 2);
        assertEq(xy.sub(1,1), 2);
    }

    function testFuzz_Add(uint x, uint y) public {
        x = bound(x, 1, 99);
        y = bound(y, 1, 99);
        assertEq(xy.add(x,y), x + y);
    }

    // function testFuzz_Sub(uint x, uint y) public {
    //     x = bound(x, 1, 99);
    //     y = bound(y, 1, 99);
    //     assertEq(xy.sub(x,y), x - y);
    // }



}