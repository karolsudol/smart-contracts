// SPDX-License-Identifier: MIT

pragma solidity ^0.8.12;

import "../../lib/ds-test/src/test.sol";

contract VerySimpleStorageTest is DSTest {
    SimpleStorage simplestorage;
function setUp() public {
        verysimplestorage = new VerySimpleStorage();
    }
function testGetInitialValue() public {
        assertTrue(simplestorage.get() == 0);
    }
function testSetValue() public {
        uint x = 300;
        simplestorage.set(x);
        assertTrue(simplestorage.get() == 300);
    }
}