// SPDX-License-Identifier: Unlicense
pragma solidity ^0.8.10;

import "ds-test/test.sol";
import "../Stake.sol";
import "./mocks/MockERC20.sol";


contract StakeTest is DSTest {
    Stake public stakeContract;
    MockERC20 public mockToken; 

    function setUp() public {
        stakeContract = new Stake();
        mockToken = new MockERC20();
    }

    function test_staking_tokens_fuzz(uint8 amount) public {
        mockToken.approve(address(stakeContract), amount);
        bool stakePassed = stakeContract.stake(amount, address(mockToken));
        assertTrue(stakePassed);
    }
}
