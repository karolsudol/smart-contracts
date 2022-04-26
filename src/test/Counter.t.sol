// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.12;

import "ds-test/test.sol";
import "solmate/test/utils/DSTestPlus.sol";
import "../Counter.sol";
// import {DSTestPlus} from "./utils/DSTestPlus.sol";

contract CounterTest is DSTestPlus {

    Counter private counter;

    function setUp() public {
        counter = new Counter();
    }

    function test_Inc() public {
        assertEq(counter.get(), 0);
        counter.inc();
        assertEq(counter.get(), 1);
    }

    function testFail_Inc() public {
        assertEq(counter.get(), 0);
        counter.inc();
        assertEq(counter.get(), 2);
    }

    function test_Dec() public {
        assertEq(counter.get(), 0);
        counter.inc();
        counter.inc();
        counter.dec();
        assertEq(counter.get(), 1);
    }

    function testFail_Dec(uint) public {
        assertEq(counter.get(), 0);
        counter.inc();
        counter.inc();
        counter.dec();
        assertEq(counter.get(), 2);
    }

    function testFuzz_Inc(uint num) public {
        num = bound(num, 1, 99);
        assertEq(counter.get(), 0);
        counter.incByNum(num);
        assertEq(counter.get(), num);
    }

    // function testFuzz_Dec(uint num) public {
    //     num = bound(num, 1, 99);
    //     assertEq(counter.get(), 0);
    //     counter.decByNum(num);
    //     assertEq(counter.get(), num);
    // }
}
