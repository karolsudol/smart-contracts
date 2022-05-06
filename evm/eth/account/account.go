package account

import (
	"context"
	"fmt"
	"math/big"

	"github.com/ethereum/go-ethereum/common"
	"github.com/ethereum/go-ethereum/common/hexutil"
	"github.com/ethereum/go-ethereum/crypto"
	"github.com/ethereum/go-ethereum/ethclient"
)

type Account struct {
	Ctx     context.Context
	Client  *ethclient.Client
	Address common.Address
}

func (a Account) GetWeiBalance(address common.Address) (*big.Int, error) {
	balance, err := a.Client.BalanceAt(a.Ctx, address, nil)
	if err != nil {
		return nil, fmt.Errorf("clinet BalanceAt err: %v", err)
	}
	return balance, nil
}

func (a Account) Transaction(address common.Address) (*big.Int, error) {
	balance, err := a.Client.BalanceAt(a.Ctx, address, nil)
	if err != nil {
		return nil, fmt.Errorf("clinet BalanceAt, err: %v", err)
	}
	return balance, nil
}

func (a Account) NewWallet() (string, error) {
	var newPrivateKey string

	privateKey, err := crypto.GenerateKey()
	if err != nil {
		return newPrivateKey, fmt.Errorf("crypto.GenerateKey err: %v", err)
	}

	privateKeyBytes := crypto.FromECDSA(privateKey)
	newPrivateKey = hexutil.Encode(privateKeyBytes)
	return newPrivateKey, nil
}

func (a Account) SendEthTo(publicKey string) error {

	return nil

}
