package main

import (
	"fmt"
	"strconv"
	"strings"
	"time"
)

func main() {
	startDateString := "01.01.1901"
	endDateString := "09.04.2065"
	startRate := 4321

	startDate := stringToDate(startDateString)
	endDate := stringToDate(endDateString)
	period := endDate.Sub(startDate).Hours() / 24

	total := getPeriodTotal(startRate, int(period)+1)

	fmt.Println(total)
}

func getPeriodTotal(startRate, period int) int {
	total := (2*startRate + period - 1) * period / 2

	return total
}

func stringToDate(dateString string) time.Time {
	dateStringParts := strings.Split(dateString, ".")
	var dateIntParts []int

	for _, part := range dateStringParts {
		intPart, _ := strconv.Atoi(part)
		dateIntParts = append(dateIntParts, intPart)
	}

	return time.Date(
		dateIntParts[2],
		time.Month(dateIntParts[1]),
		dateIntParts[0],
		0,
		0,
		0,
		0,
		time.UTC,
	)
}
