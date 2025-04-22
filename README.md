## Integration Testing Report

### Test 1: Insert Question
- Input: "How do I reset my password?"
- Action: Click "Send"
- Expected: Confirmation MessageBox and saved to DB
- Result: ✅ Passed

### Test 2: Show All
- Action: Click "Show all"
- Expected: List of all questions in a MessageBox
- Result: ✅ Passed

### Test 3: Delete by ID
- Input: 1 (assuming ID exists)
- Action: Click "Delete"
- Expected: Confirmation of deletion
- Result: ✅ Passed

### Tools Used:
- Manual Testing via C# WinForms UI
- DB Browser to validate stored data
