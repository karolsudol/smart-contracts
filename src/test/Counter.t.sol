// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.10;

// import "lib/ds-test/src/test.sol";
import "ds-test/test.sol";
import "../Counter.sol";

contract CounterTest is DSTest {

    Counter private counter;

    function setUp() public {
        counter = new Counter();
    }

    function testInc() public {
        assertEq(counter.get(), 0);
        counter.inc();
        assertEq(counter.get(), 1);
    }

    function testDecr() public {
        assertEq(counter.get(), 0);
        counter.inc();
        counter.inc();
        counter.dec();
        assertEq(counter.get(), 1);
    }

    function testIncByNum(uint num) public {
        assertEq(counter.get(), 0);
        counter.incByNum(num);
        assertEq(counter.get(), num);
    }
}
