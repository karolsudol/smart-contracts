// SPDX-License-Identifier: MIT

pragma solidity ^0.8.12;

import "../../lib/ds-test/src/test.sol";
import "../VerySimpleStorage.sol";

contract VesySimpleStorageTest is DSTest {
    VerySimpleStorage verysimplestorage;
function setUp() public {
        verysimplestorage = new VerySimpleStorage();
    }
function testGetInitialValue() public {
        assertTrue(verysimplestorage.get() == 0);
    }
function testSetValue() public {
        uint x = 300;
        verysimplestorage.set(x);
        assertTrue(verysimplestorage.get() == 300);
    }
}