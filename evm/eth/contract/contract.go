package contract

import (
	"context"

	"github.com/ethereum/go-ethereum/ethclient"
)

type Contract struct {
	Ctx    context.Context
	Client *ethclient.Client
}
