# Question Scoring Model

| Dimension | Points | Question Addressed |
|---|---:|---|
| Accuracy | 0–4 | Are the conclusion and the relevant details correct? |
| Groundedness | 0–3 | Is every claim supported by real evidence? |
| Completeness | 0–2 | Does the response fully answer the question? |
| Clarity and Precision | 0–1 | Is the response specific and understandable? |

## Accuracy: 0–4 points

| Score | Decision Rule |
|---:|---|
| 4 | The correct conclusion is reached. No contradictions are present. |
| 3 | The correct conclusion is reached with a small error. |
| 2 | Meaningful correct content exists, but an error or omission affects the answer. |
| 1 | Only a small portion of the response is correct. Important details are incorrect or missing. |
| 0 | A wrong or contradictory conclusion is made, a definitive answer to an unanswerable question is given, or no response is provided. |

## Groundedness: 0–3 points

| Score | Decision Rule |
|---:|---|
| 3 | Every claim is supported by timeline events, file paths or timestamps, or documented evidence limitations. |
| 2 | The answer is supported, but one minor unsupported interpretation is added. |
| 1 | Important claims rely on assumptions instead of evidence from the given timeline. |
| 0 | The conclusion is not supported, is contradictory to provided evidence, or is asserted despite the evidence being unable to answer it. |

## Completeness: 0–2 points

| Score | Decision Rule |
|---:|---|
| 2 | All required fields or events are included. The response follows the requested scope and constraints. |
| 1 | Mostly correct but missing a relevant event, rationale, or evidentiary limitation. |
| 0 | Incomplete, nonresponsive, or largely outside the requested scope. |

## Expected Completeness by Question Type

| Category | Minimum Complete Answer |
|---|---|
| Lookup | The file path, event type (when requested), and time are all present. |
| Summary | All listed events are in scope, in the correct chronological order, and no invented activity appears. |
| Unusual Activity | A conclusion, relevant supporting events, and an explanation of why the activity is noteworthy are all present. |
| Counting | The correct total and supporting evidence consistent with the total are provided. |
| Unanswerable | A clear statement that the answer cannot be determined and an explanation of why the evidence is insufficient are provided. |

## Clarity and Precision: 0–1 point

| Score | Decision Rule |
|---:|---|
| 1 | The response uses file paths and timestamps (when required). Evidence is differentiated from interpretation. |
| 0 | The response is vague, contradictory, or imprecise about file paths or timestamps. |

## Grading Rubric per Question

| Dimension | Score | Comments |
|---|---:|---|
| Accuracy | ___/4 | |
| Groundedness | ___/3 | |
| Completeness | ___/2 | |
| Clarity and Precision | ___/1 | |
| **Total Score** | **___/10** | |

## Grading Rubric per Timeline

| Category | Score | Comments |
|---|---:|---|
| Lookup Score | ___/40 | |
| Summary Score | ___/40 | |
| Unusual Activity Score | ___/40 | |
| Counting Score | ___/40 | |
| Unanswerable Score | ___/40 | |
| **Total Score** | **___/200** | |
| Critical Errors? | yes / no | |