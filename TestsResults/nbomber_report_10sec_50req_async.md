> test info

test suite: `nbomber_default_test_suite_name`

test name: `nbomber_default_test_name`

session id: `2023-08-05_15.20.70_session_b249afc`

> scenario stats

scenario: `Обращение по адресу: tests/async.`

- ok count: `492`

- fail count: `0`

- all data: `0` MB

- duration: `00:00:10`

load simulations:

- `inject`, rate: `50`, interval: `00:00:01`, during: `00:00:10`

| step               | ok stats                                                               |
| ------------------ | ---------------------------------------------------------------------- |
| name               | `global information`                                                   |
| request count      | all = `492`, ok = `492`, RPS = `49,2`                                  |
| latency            | min = `2206,58`, mean = `5738,7`, max = `12200,26`, StdDev = `2511,52` |
| latency percentile | p50 = `4321,28`, p75 = `6967,3`, p95 = `10420,22`, p99 = `11575,3`     |

> status codes for scenario: `Обращение по адресу: tests/async.`

| status code | count | message |
| ----------- | ----- | ------- |
| OK          | 492   |         |

THREADPOOL: THREAD-COUNT: 13
