# GUARDIAN USER FLOW

## Complete Journey Map for Guardian Archetype

### 🚀 **ENTRY POINTS**
1. **Main Chambers Page** → `/chamber`
2. **Direct Guardian Chamber** → `/chamber/guardian`

---

### 📍 **STEP 1: Guardian Chamber Landing**
**URL:** `/chamber/guardian`
- **Content:** Guardian archetype overview, description, and characteristics
- **Action:** User learns about being a Guardian
- **Next:** User clicks "The Path" or "Breaker" button

---

### ⚡ **STEP 2: Breaker Page**
**URL:** `/chamber/guardian/breaker`
- **Content:**
  - "Path to Future Self: The Wall of the World"
  - Mythic language about becoming the Bastion
  - Field signs and guardian's law
  - 5-minute read with powerful motivation
- **Action:** User clicks "Begin the Breaker's Rite"
- **Next:** Redirects to Payment Gateway

---

### 🛤️ **STEP 3: The Path (Payment Gateway)**
**URL:** `/chamber/guardian/the-path`
- **Content:** 
  - "GUARDIAN — The Commitment to Unbreakable Stability"
  - Payment gateway with $27 fee
  - Motivational content about fortifying foundations
  - Benefits of taking the stage test
- **Action:** User clicks "Fortify My Path — $27 Initiation"
- **Next:** Redirects to Stage Quiz

---

### 🧠 **STEP 4: Stage Quiz (20 Questions)**
**URL:** `/chamber/guardian/breaker/the-path/field-proof/free-walk`
- **Content:**
  - "Stage/Masks Diagnostic Quiz"
  - 20 questions to determine exact stage and mask
  - Progress bar showing completion
  - Guardian-themed blue/indigo styling
- **Action:** User answers all 20 questions
- **Next:** Results page with diagnosis

---

### 📊 **STEP 5: Quiz Results**
**URL:** `/chamber/guardian/breaker/the-path/field-proof/free-walk/results`
- **Content:**
  - Stage diagnosis (Protector, Boundary Keeper, Anchor, Pillar, Bastion)
  - Mask identification
  - Stage progress bars for all 5 stages
  - "Your True Need" section
  - **Single Action Button:** "Recommended Rituals"
- **Action:** User clicks "Recommended Rituals"
- **Next:** Rituals page

---

### 🔮 **STEP 6: Recommended Rituals**
**URL:** `/chamber/guardian/rituals`
- **Content:**
  - Stage-specific rituals for progression
  - Practices to move from current stage to next
  - Ritual library with 30+ advanced practices
  - Guardian-specific ritual descriptions
- **Action:** User practices rituals to evolve
- **Next:** User can retake quiz to measure progress

---

## 🔄 **ALTERNATIVE FLOWS**

### **Flow A: Standard Journey**
```
Chamber → Breaker → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow B: Direct Path (Alternative)**
```
Chamber → The Path → Payment Gateway → Stage Quiz → Results → Rituals
```

### **Flow C: Retake Quiz**
```
Results → Stage Quiz → New Results → Rituals
```

---

## 🎯 **KEY FEATURES**

### **Payment Integration**
- **$27 fee** for stage quiz access
- **Payment gateway** with motivational content about fortification
- **Seamless redirect** to quiz after payment

### **Stage Detection**
- **5 stages:** Protector → Boundary Keeper → Anchor → Pillar → Bastion
- **Mask identification** for each stage
- **Progress tracking** across all stages
- **Personalized diagnosis** with specific needs

### **Ritual System**
- **Stage-specific practices** for progression
- **Advanced ritual library** with 30+ practices
- **Targeted evolution** from current to next stage

### **User Experience**
- **Beautiful UI** with blue/indigo guardian theme
- **Responsive design** for all devices
- **Smooth navigation** between pages
- **Clear call-to-actions** at each step

---

## 📱 **MOBILE EXPERIENCE**
- **Responsive buttons** that stack on mobile
- **Readable text** at all screen sizes
- **Touch-friendly** quiz interface
- **Smooth animations** optimized for mobile

---

## 🎨 **VISUAL THEME**
- **Primary Colors:** Blue (#1e3a8a) and Indigo (#3b82f6)
- **Background:** Black with subtle gradients
- **Animations:** Pulse effects, glowing borders
- **Typography:** Bold, protective, motivational

---

## 🔧 **TECHNICAL IMPLEMENTATION**
- **Next.js routing** with dynamic archetype parameters
- **React state management** for quiz progress
- **URL parameters** for quiz results sharing
- **Conditional rendering** for guardian-specific content
- **Responsive CSS** with Tailwind

---

## 📈 **CONVERSION OPTIMIZATION**
- **Clear value proposition** at payment gateway
- **Single action button** on results page
- **Motivational language** throughout journey
- **Progress visualization** to show advancement
- **Personalized recommendations** based on results

---

## 🎯 **SUCCESS METRICS**
- **Payment conversion** from gateway to quiz
- **Quiz completion rate** (20 questions)
- **Ritual engagement** after results
- **Return visits** for progress tracking
- **Stage progression** over time

---

## 🛡️ **GUARDIAN-SPECIFIC CONTENT**

### **Payment Gateway Theme**
- **"The Commitment to Unbreakable Stability"**
- **Fortification language** instead of revelation
- **Foundation reinforcement** messaging
- **Protection investment** narrative

### **Stage Progression**
- **Protector:** Endless protecting, never receiving
- **Boundary Keeper:** Strong walls, missing connection
- **Anchor:** Stable presence, limited growth
- **Pillar:** Supporting others, neglecting self
- **Bastion:** Unbreakable foundation for all

### **Ritual Focus**
- **Stability practices** for resilience
- **Boundary work** for healthy protection
- **Vulnerability acceptance** rituals
- **Self-care integration** practices

---

*This flow creates a complete, engaging journey for Guardian users to discover their stage, understand their mask, and access targeted rituals for evolution.* 