> test info

test suite: `nbomber_default_test_suite_name`

test name: `nbomber_default_test_name`

session id: `2023-08-05_15.19.24_session_ce0cff67`

> scenario stats

scenario: `Обращение по адресу: tests/sync.`

- ok count: `382`

- fail count: `0`

- all data: `0` MB

- duration: `00:00:10`

load simulations:

- `inject`, rate: `50`, interval: `00:00:01`, during: `00:00:10`

| step               | ok stats                                                                |
| ------------------ | ----------------------------------------------------------------------- |
| name               | `global information`                                                    |
| request count      | all = `382`, ok = `382`, RPS = `38,2`                                   |
| latency            | min = `2169,31`, mean = `7364,84`, max = `19639,12`, StdDev = `2756,72` |
| latency percentile | p50 = `7331,84`, p75 = `9363,46`, p95 = `12107,78`, p99 = `12378,11`    |

> status codes for scenario: `Обращение по адресу: tests/sync.`

| status code | count | message |
| ----------- | ----- | ------- |
| OK          | 382   |         |

THREADPOOL: THREAD-COUNT: 13
