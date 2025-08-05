# MASK NODE — DIAGNOSTIC QUIZ MODULE IMPLEMENTATION

## Overview
Successfully implemented a comprehensive modular diagnostic quiz module for the **MASK Node** archetype in the field-proof/free-walk section.

## What Was Implemented

### 1. **5 Developmental Stages**
- **The Hider** - Hides from the world and from yourself, avoids being seen
- **The Mimic** - Copies others' behavior and adapts to fit in, mirrors the strongest person
- **The Actor** - Performs different roles and adapts behavior to fit situations
- **The Shadow** - Embraces shadow side and reveals true feelings, even when risky
- **The Unveiled** - Naked truth, wears no mask, reveals authentic self without fear

### 2. **20 Questions (4 per stage)**
- Each question has **5 answer choices** with values **1-5**
- Questions are **randomized** during the quiz
- **Explicit mapping** of answer value → stage maturity
- **Value logic** clearly defined for each question

### 3. **Complete Scoring System**
- **Dominant stage** = highest total score (true field maturity)
- **Mask stage** = lowest total score (shadow, resistance, fallback)
- **Tiebreaker logic** implemented for equal scores
- **Dynamic value scale support** (1-4 and 1-5 scales)

### 4. **25-Outcome Diagnosis Grid**
- **Complete mapping** of all (Dominant|Mask) combinations
- **Poetic, field-style messages** for each outcome
- **Structured diagnosis** with:
  - Title
  - Diagnosis
  - Reality
  - Tension
  - Law to Walk
  - If You Stay
  - If You Act

### 5. **Technical Implementation**
- **Updated mask.ts** with complete stage definitions
- **Enhanced quizScoring.ts** to handle 1-5 value scale (already implemented)
- **Updated results page** for dynamic value scale support (already implemented)
- **Maintained compatibility** with existing 1-4 scale archetypes

## Key Features

### **Modular Design**
- Can be copied for any archetype
- Just update stage names, questions, and 25 outcomes
- Maintains consistent structure across all archetypes

### **Dynamic Value Scale**
- Automatically detects 1-4 vs 1-5 scale
- Adjusts progress thresholds accordingly
- Maintains backward compatibility

### **Comprehensive Diagnosis**
- 25 unique outcomes covering all combinations
- Field-style language and insights
- Actionable guidance for each outcome

### **User Experience**
- Randomized question order
- Visual progress tracking
- Animated stage indicators
- Comprehensive results display

## File Locations
- **Archetype Definition**: `hussamallah/lib/archetypes/mask.ts`
- **Scoring Logic**: `hussamallah/lib/quizScoring.ts` (already enhanced)
- **Quiz Interface**: `hussamallah/app/chamber/[archetype]/breaker/the-path/field-proof/free-walk/page.tsx`
- **Results Display**: `hussamallah/app/chamber/[archetype]/breaker/the-path/field-proof/free-walk/results/page.tsx`

## Usage
1. Navigate to `/chamber/mask/breaker/the-path/field-proof/free-walk`
2. Answer 20 questions (randomized order)
3. Receive comprehensive (Dominant|Mask) diagnosis
4. Get actionable insights and guidance

## Stage Progression

### **The Hider → The Mimic**
- Learn to step into the light and risk being seen
- Begin to reveal your true self
- Move from hiding to adapting

### **The Mimic → The Actor**
- Learn to act as yourself, no matter what
- Develop your own voice and authentic expression
- Move from copying to performing

### **The Actor → The Shadow**
- Learn to hold your ground and show your real self
- Choose authenticity over performance
- Move from acting to revealing

### **The Shadow → The Unveiled**
- Learn to integrate shadow and light
- Balance honesty with wisdom about when to reveal
- Move from revealing to being unveiled

### **The Unveiled**
- Master the art of being unveiled
- Guide others to their own unveiling
- Become naked truth that transforms everything

## Key Insights

### **The Hider**
- Hides from the world and from self
- Avoids being seen and prefers invisibility
- Needs to step into light and risk being seen

### **The Mimic**
- Copies others' behavior and adapts to fit in
- Mirrors the strongest person in the room
- Needs to develop own voice and authentic expression

### **The Actor**
- Performs different roles and adapts behavior
- Skilled at playing parts
- Needs to hold ground and show real self

### **The Shadow**
- Embraces shadow side and reveals true feelings
- Takes risks in revealing uncomfortable truths
- Needs to integrate shadow and light

### **The Unveiled**
- Naked truth, wears no mask
- Reveals authentic self without fear or shame
- Transforms everything around them

## Next Steps
This module can serve as a template for implementing similar diagnostic quizzes for other archetypes. The structure is modular and can be easily adapted by:
1. Updating stage names and descriptions
2. Replacing questions with archetype-specific content
3. Creating new 25-outcome diagnosis grids
4. Maintaining the same technical infrastructure

The MASK diagnostic quiz is now fully functional and ready for use! 